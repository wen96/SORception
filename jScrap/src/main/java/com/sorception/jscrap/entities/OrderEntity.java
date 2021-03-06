package com.sorception.jscrap.entities;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

import com.fasterxml.jackson.annotation.JsonIgnore;

@Entity
@Table(name = "Orders")
public class OrderEntity extends AbstractEntity implements ISoftDeletable {
	@Column(name = "sgId", unique = true)
	private String sgId;
	
	@Column(name = "closed")
	private Boolean closed;
	
	@OneToMany(mappedBy = "order", 
			fetch = FetchType.EAGER,
			cascade = CascadeType.ALL)
	private List<OrderLineEntity> lines;
	
	@Temporal(TemporalType.TIMESTAMP)
	@Column(name = "deadline")
    private Date deadline;
	
	@Column(name = "deleted", nullable = false)
	private Boolean deleted;
	
	public OrderEntity() {}

	public OrderEntity(String sgId,
			List<OrderLineEntity> lines) {
		this.sgId = sgId;
		setLines(lines);
		this.closed = false;
		this.deleted = false;
	}
	
	public Date getDeadline() {
		return deadline;
	}
	
	public String getSgId() {
		return sgId;
	}

	public List<OrderLineEntity> getLines() {
		List<OrderLineEntity> validLines = new ArrayList<>();
		for(OrderLineEntity line : lines) {
			if(!line.isDeleted())
				validLines.add(line);
		}
		return validLines;
	}
	
	@JsonIgnore
	public Boolean isClosed() {
		return closed;
	}
	
	@JsonIgnore
	@Override
	public Boolean isDeleted() {
		return deleted;
	}
	
	@JsonIgnore
	public OfferEntity getOffer() {
		if(!lines.isEmpty() && lines.get(0).getOfferLine() != null)
			return lines.get(0).getOfferLine().getOffer();
		return null;
	}
	
	public void setLines(List<OrderLineEntity> lines) {
		this.lines = lines;
		for(OrderLineEntity line : lines) {
			line.setOrder(this);
		}
	}
	
	public void setDeadline(Date deadline) {
		this.deadline = deadline;
	}

	public void setClosed(boolean closed) {
		this.closed = closed;
	}

	@Override
	public void setDeleted(Boolean deleted) {
		this.deleted = deleted; 
	}
}
