/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.sorception.jscrap.services;

import com.sorception.jscrap.dao.SettingsDAO;
import com.sorception.jscrap.entities.SettingsEntity;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author kaseyo
 */
@Service
public class SettingsService {
    @Autowired
    private SettingsDAO settingsDAO;
    
    public SettingsEntity getGlobalSettings() {
        return settingsDAO.getGlobalSettings();
    }
}