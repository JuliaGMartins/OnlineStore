import React from 'react';
import './Header.css';
//import {NavLink, Link} from 'react-router-dom'

export const Header = () => {
    return(
        <nav>
            <div className='header'>
                
                    <button className='button'>Home</button>
               
                    <button className='button'>Search Product</button>
               
                    <button className='button'>My Profile</button>
                
            </div>
        </nav>
    )
}