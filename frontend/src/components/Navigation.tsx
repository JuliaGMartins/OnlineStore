import React from 'react';
 
import { NavLink } from 'react-router-dom';
 
const Navigation = () => {
    return (
       <div>
          <NavLink to="/contact">ProductSearchPage</NavLink>
          <NavLink to="/about">LoginPage</NavLink>
          <NavLink to="/">CartPage</NavLink>
          
       </div>
    );
}
 
export default Navigation;