/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.sorception.jscrap.entities;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

/**
 *
 * @author kaseyo
 */
@Entity
@Table(name="User")
public class UserEntity extends AbstractEntity {
    @Column(name = "name")
    private String name;
    
    @Column(name = "isAdmin")
    private Boolean admin = false;

    @Column(name = "username", unique = true)
    private String username;
    
    public UserEntity() {}

    public UserEntity(String username, String name) {
        this.username = username;
        this.name = name;
    }

    public String getName() {
        return name;
    }
    
    public String getUsername() {
        return username;
    }
    
    public Boolean getIsAdmin() {
        return admin;
    }
}
