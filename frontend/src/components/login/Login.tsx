import { Axios } from "axios";
import { useState } from "react";
import { Button } from "react-bootstrap";
import instance from "../../services/Api";
import { useNavigate } from "react-router-dom";
import './Login.css'

export default function Login(props){

    const [userName, setUserName] = useState("");
    const [password, setPassword] = useState("");
    const [loginStatus, setLoginStatus] = useState(false);
    const [loginFinished, setLoginFinished] = useState(false);
    const navigate = useNavigate();

    const handleChangeUsername = e => {
        setUserName(e.target.value);
    }

    const handleChangePassword = e => {
        setPassword(e.target.value);
    }

    async function login(){
        setLoginFinished(false)
        const response = await instance.post<string>(
            "/api/Auth/token",
            {
                "name": "dummy",
                "userName": userName,
                "password": password,
                "role": 0
            }
        );
            //Atribuir a variável de estado
        // setProducts(productsByColor.data)
        // setProductsLoaded(true)
        if(response.status === 200) {
            const token = response.data;
            localStorage.setItem("token", token);
            localStorage.setItem("userName", userName);
            setLoginStatus(true);
            navigate('/HomePage');
        } else {
            setLoginStatus(false);
        }
        setLoginFinished(true);
    }

    async function register(){
        navigate('/RegisterPage')
    }

    return(
        //<h1>Teste</h1>
        
        <div id="centralize">
        <form id="left">
            <label className="productName">
                Username:
                {/* <input type="text" name="name" /> */}
                <input id="box" onChange={handleChangeUsername} value={userName} type="text" name="name" ></input>
            </label>
            {/* <input type="submit" value="Submit" /> */}
            <br></br>
            <label className="productName">
                Password:
                {/* <input type="text" name="name" /> */}
                <input id="box" onChange={handleChangePassword} value={password} type="text" ></input>
            </label>
            <br></br>
            <Button id="loginButtons" onClick={async () => await login()}>Login</Button>
            <Button id="loginButtons" onClick={async () => await register()}>Register</Button>
        </form></div>
    )
    
}