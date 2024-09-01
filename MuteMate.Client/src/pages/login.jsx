import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import "../Styles/login.css";
import { NavLink } from "react-router-dom";

function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [rememberme, setRememberme] = useState(false);
  const [error, setError] = useState("");
  const navigate = useNavigate();

  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    if (name === "email") setEmail(value);
    if (name === "password") setPassword(value);
    if (name === "rememberme") setRememberme(checked);
  };

  const handleRegisterClick = () => {
    navigate("/register");
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!email || !password) {
      setError("Please fill in all fields.");
    } else {
      setError("");
      const loginurl = `${ENDPOINTS.LOGIN}`;
      // ? `${ENDPOINTS.LOGIN}?useCookies=true`
      // : `${ENDPOINTS.LOGIN}`;
      console.log("remember me is: ", rememberme);

      fetch(loginurl, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          email: email,
          password: password,
        }),
      })
        .then((response) => {
          console.log("response", response);
          if (!response.ok) {
            setError("Error Logging In.");
            throw new Error("login failed");
          }
          return response.json();
        })
        .then((data) => {
          console.log("response data", data);
          if (!data.accessToken) {
            throw new Error("No token found in response");
          }

          const token = data.accessToken;
          console.log("token is:", token);

          if (rememberme) {
            console.log("sparar token i LocalStorage");
            localStorage.setItem("token", token);
            localStorage.setItem("isLoggedIn", true);
          } else {
            console.log("sparar token i SessionStorage");
            sessionStorage.setItem("token", token);
            sessionStorage.setItem("isLoggedIn", true);
          }

          fetchUserData(token);
        })
        .catch((error) => {
          console.error(error);
          setError("Error Logging in.");
        });
    }
  };

  const fetchUserData = async (token) => {
    try {
      const response = await fetch(`${ENDPOINTS.PINGAUTH}`, {
        method: "GET",
        headers: {
          "Content-type": "application/json",
          Authorization: `Bearer ${token}`,
        },
      });

      if (!response.ok) {
        throw new Error("Could not get the info you wanted");
      }

      const userData = await response.json();
      console.log("userdata: ", userData);

      if (userData && userData.email) {
        if (rememberme) {
          //här ävan ha med userdata.id
          // localStorage.setItem("loggedInUserId", userData.id);
          localStorage.setItem("loggedInUserName", userData.email);
        } else {
          //här ävan ha med userdata.id
          // sessionStorage.setItem("loggedInUserId", userData.id);
          sessionStorage.setItem("loggedInUserName", userData.email);
        }

        console.log("User logged in:", userData.email);
        setError("Successful Login.");

        window.location.href = "/";
      } else {
        setError("Invalid response data");
        console.log("problem med response data");
      }
    } catch (error) {
      console.error(error);
      setError("Error Logging in.");
    }
  };

  return (
    <>
      <div className="login-container">
        <div className="containerbox">
          <h3 className="login-text">Login</h3>
          <div className="image-container"></div>
          <div className="form-container">
            <form onSubmit={handleSubmit}>
              <label className="forminput" htmlFor="email">
                Email:
              </label>

              <input
                type="email"
                id="email"
                name="email"
                value={email}
                onChange={handleChange}
              />

              <label className="forminput" htmlFor="password">
                Password:
              </label>

              <div>
                <input
                  type="password"
                  id="password"
                  name="password"
                  value={password}
                  onChange={handleChange}
                />
              </div>

              <div className="register-checkbox-container">
                <input
                  className="checkbox-input"
                  type="checkbox"
                  id="rememberme"
                  name="rememberme"
                  checked={rememberme}
                  onChange={handleChange}
                />
                <span className="rememberme-text">Remember Me</span>
              </div>
              {error && <p className="log-in-error">{error}</p>}
              <div className="register-btn-container">
                <button className="login-button" type="submit">
                  Login
                </button>
                <NavLink className="register-login" to="/register">
                  No account? Sign up!
                </NavLink>
              </div>
            </form>
          </div>
        </div>
      </div>
    </>
  );
}

export default Login;
