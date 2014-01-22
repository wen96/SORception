package com.sorception.jscrap.entities;

import java.util.ArrayList;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.FetchType;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.transaction.annotation.Transactional;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.sorception.jscrap.services.ActiveMQService;

@Entity
@Table(name = "Offer")
public class OfferEntity extends AbstractEntity {
	
	final static Logger logger = LoggerFactory.getLogger(OfferEntity.class);
	
	@OneToMany(mappedBy = "_offer",
			cascade = CascadeType.ALL,
			fetch = FetchType.EAGER)
	private List<OfferLineEntity> _lines;
	
	@Column(name = "deleted")
	private Boolean _deleted = false;
	
	@Column(name = "orderSgId", nullable = false)
	private String _orderSgId;
	
	public OfferEntity() {}
	
	public OfferEntity(List<OfferLineEntity> lines) {
		this.setLines(lines);
	}
	
	public void setDeleted(Boolean deleted) {
		this._deleted = deleted;
	}
	
	public String getOrderSgId() {
		return this._orderSgId;
	}
	
	public List<OfferLineEntity> getLines() {
		List<OfferLineEntity> activeLines = new ArrayList<>();
		for(OfferLineEntity line : this._lines) {
			if(!line.isDeleted())
				activeLines.add(line);
		}
		return activeLines;
	}
	
	@JsonIgnore
	public Boolean isDeleted() {
		return this._deleted;
	}
	
	@JsonIgnore
	public List<OfferLineEntity> getAccepted() {
		List<OfferLineEntity> accepted = new ArrayList<>();
		for(OfferLineEntity line : getLines()) {
			if(line.getAcceptedOffer() != null)
				accepted.add(line);
		}
		return accepted;
	}
	
	public void setLines(List<OfferLineEntity> lines) {
		this._lines = lines;
		for(OfferLineEntity line : lines) {
			if(line.getOrderLine() != null)
				this._orderSgId = line.getOrderLine().getOrder().getSgId();
			line.setOffer(this);
		}
	}
	
	@JsonIgnore
	public OrderEntity getOrder() {
		if(!_lines.isEmpty() && _lines.get(0).getOrderLine() != null)
			return _lines.get(0).getOrderLine().getOrder();
		return null;
	}
	
	public Long getOrderId() {
		OrderEntity order = getOrder();
		return order != null ? order.getId() : null;
	}
}
