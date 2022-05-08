import React from 'react';
import './Header.css';
import Select from 'react-select';
import { Dropdown, DropdownButton, Nav } from 'react-bootstrap';
import NavDropdown from 'react-bootstrap/NavDropdown'
import { Link, NavLink } from 'react-router-dom';
import { useState } from 'react'
import Login from '../login/Login';

export const Header = () => {
    return(
        <nav>
            <div className='header'>
                
                    <Link id='button' to="/">Home</Link>
                    <Link id='button' to="/ProductSearchPage">Search Product</Link>

                    <NavDropdown id='button' title="My Profile">
                        <NavDropdown.Item id='buttonDrop' eventKey="1">
                            <Link id='buttonDrop' to="/LoginPage">Log out</Link>
                        </NavDropdown.Item>
                        <NavDropdown.Divider />
                        <NavDropdown.Item id='buttonDrop' eventKey="2">
                            <Link id='buttonDrop' to="/CartPage">Cart</Link>
                        </NavDropdown.Item>
                    </NavDropdown>
                
            </div>
        </nav>
    );
}

