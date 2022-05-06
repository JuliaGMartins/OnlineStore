import React from 'react';
import './Header.css';
import Select from 'react-select';
import { Dropdown, DropdownButton, Nav } from 'react-bootstrap';
import NavDropdown from 'react-bootstrap/NavDropdown'
import { NavLink } from 'react-router-dom';
import { useState } from 'react'
import Login from '../login/Login';

export const Header = () => {
    return(
        <nav>
            <div className='header'>
                
                    <button className='button'>Home</button>
               
                    <button className='button'>Search Product</button>

                    <NavDropdown className='button' title="My Profile">
                        <NavDropdown.Item className='button' eventKey="1">Log out</NavDropdown.Item>
                        <NavDropdown.Divider />
                        <NavDropdown.Item className='button' eventKey="2">Cart</NavDropdown.Item>
                    </NavDropdown>
                
            </div>
        </nav>
    );
}

