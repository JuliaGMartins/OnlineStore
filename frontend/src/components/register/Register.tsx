import { useState } from "react";
import { Button } from "react-bootstrap";
import { useNavigate } from "react-router-dom";
import instance from "../../services/Api";
import './Register.css'

export default function Register(){

    const [userName, setUserName] = useState("");
    const [name, setName] = useState("");
    const [password, setPassword] = useState("");
    const [registerStatus, setRegisterStatus] = useState(false);
    const [registerFinished, setRegisterFinished] = useState(false);
    const navigate = useNavigate();
    

    const handleChangeUsername = e => {
        setUserName(e.target.value);
    }

    const handleChangePassword = e => {
        setPassword(e.target.value);
    }

    const handleChangeName = e => {
        setName(e.target.value);
    }

    async function register(){
        setRegisterFinished(false)
        const response = await instance.post<string>(
            "/api/User/CreateUser",
            {
                "name": name,
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
            setRegisterStatus(true);
            navigate(`/LoginPage`);
        } else {
            setRegisterStatus(false);
        }
        setRegisterFinished(true);
    }

    function cancel() {
        navigate('/LoginPage')
    }

    return(
        //<h1>Teste</h1>
        
        <div id="centralize">
        <form id="left">
            <label className="productName">
                Username:
                <input id="box" onChange={handleChangeUsername} value={userName} type="text" name="username" ></input>
            </label>
            <br></br>
            <label className="productName">
                Name:
                <input id="box" onChange={handleChangeName} value={name} type="text" name="name" ></input>
            </label>
            <br></br>
            <label className="productName">
                Password:
                <input id="box" onChange={handleChangePassword} value={password} type="text" name="password" ></input>
            </label>
            <br></br>
            <Button id="loginButtons" onClick={async () => register()}>Register</Button>
            <Button id="loginButtonsCancel" onClick={cancel}>Cancel</Button>
        </form></div>
    )
}