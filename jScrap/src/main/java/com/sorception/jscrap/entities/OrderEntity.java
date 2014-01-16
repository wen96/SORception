package com.sorception.jscrap.entities;

import java.util.Date;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

import org.codehaus.jackson.annotate.JsonIgnore;
import org.codehaus.jackson.annotate.JsonManagedReference;

@Entity
@Table(name = "Orders")
public class OrderEntity extends AbstractEntity {
	@Column(name = "sgId")
	private String _sgId;
	
	@OneToMany(mappedBy = "_order", 
			fetch = FetchType.EAGER,
			cascade = CascadeType.ALL)
	private List<OrderLineEntity> _lines;
	
	@Temporal(TemporalType.TIMESTAMP)
	@Column(name = "deadline")
    private Date _deadline;
	
	public OrderEntity() {}

	public OrderEntity(String sgId,
			List<OrderLineEntity> lines) {
		this._sgId = sgId;
		this._lines = lines;
		for(OrderLineEntity line : lines) {
			line.setOrder(this);
		}
	}
	
	public Date getDeadline() {
		return _deadline;
	}
	
	public String getSgId() {
		return _sgId;
	}

	public List<OrderLineEntity> getLines() {
		return _lines;
	}
	
	public void setDeadline(Date deadline) {
		this._deadline = deadline;
	}
}
