/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.sorception.jscrap.entities;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

/**
 *
 * @author kaseyo
 */
@Entity
@Table(name = "Token")
public class TokenEntity extends AbstractEntity {
    @Column(name = "Token")
    private String _token;
    
    @Column(name = "Status")
    @Enumerated(EnumType.STRING)
    private TokenStatus _status;
    
    public enum TokenStatus {
        VALID,
        REQUESTED,
        EXPIRED;
    }
    
    public TokenEntity() {}
    
    public TokenEntity(String token, TokenStatus status){
        this._token = token;
        this._status = status;
    }
    
    public String getToken() {
        return this._token;
    }
    
    public TokenStatus getStatus() {
        return _status;
    }
}
