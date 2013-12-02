/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.sorception.jscrap.services;

import com.sorception.jscrap.dao.TokenDAO;
import com.sorception.jscrap.entities.TokenEntity;
import com.sorception.jscrap.error.ResourceNotFoundException;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

/**
 *
 * @author kaseyo
 */
@Service
@Transactional
public class TokenService {
    @Autowired
    TokenDAO tokenDAO;
    
    public void requestToken() {
        // Access to web service
        TokenEntity tokenEntity = new TokenEntity("", TokenEntity.TokenStatus.REQUESTED);
        tokenDAO.save(tokenEntity);
    }
    
    public void saveValid(String token) {
        TokenEntity tokenEntity = new TokenEntity(token, TokenEntity.TokenStatus.VALID);
        tokenDAO.save(tokenEntity);
    }
    
    public TokenEntity getValid() {
        TokenEntity tokenEntity = tokenDAO.getValid();
        if(null == tokenEntity) 
            throw new ResourceNotFoundException();
        return tokenEntity;
    }
    
    public List<TokenEntity> list() {
        return tokenDAO.list();
    }
}