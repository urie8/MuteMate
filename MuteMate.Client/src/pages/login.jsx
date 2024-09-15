import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import "../Styles/login.css";
import { NavLink } from "react-router-dom";
import Spinner from "../components/spinner";

function Login() {
  // state variables for email and password
  const [userName, setUserName] = useState("");
  const [password, setPassword] = useState("");
  const [rememberme, setRememberme] = useState(false);
  const [loading, setLoadning] = useState(false);
  // state variable for error messages
  const [error, setError] = useState("");
  const navigate = useNavigate();

  // handle change events for input fields
  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    if (name === "userName") setUserName(value);
    if (name === "password") setPassword(value);
    if (name === "rememberme") setRememberme(checked);
  };

  const handleRegisterClick = () => {
    navigate("/register");
  };

  // handle submit event for the form
  const handleSubmit = (e) => {
    e.preventDefault();
    // validate email and password
    if (!userName || !password) {
      setError("Please fill in all fields.");
    } else {
      // clear error message
      setError("");
      // post data to the /login api
      const loginurl = rememberme
        ? `${ENDPOINTS.LOGIN}?useCookies=true`
        : `${ENDPOINTS.LOGIN}?useSessionCookies=true`;
      setLoadning(true);
      fetch(loginurl, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          username: userName,
          password: password,
        }),
        credentials: "include",
      })
        .then((response) => {
          // handle success or error from the server
          if (response.ok) {
            window.location.href = "/";
          } else {
            setError("Error Logging In.");
            setLoadning(false);
          }
        })
        .catch((error) => {
          // handle network error
          console.error(error);
          setError("Error Logging in.");
          setLoadning(false);
        });
    }
  };

  return (
    <>
      <div className="login-container">
        <div className="containerbox">
          <h3 className="login-text">Login</h3>
          {/* <div className="img-container"></div> */}
          <div className="image-container"></div>
          <div className="form-container">
            <form onSubmit={handleSubmit}>
              <label className="forminput" htmlFor="userName">
                Username:
              </label>

              <input
                className="register-input"
                type="text"
                id="userName"
                name="userName"
                value={userName}
                onChange={handleChange}
              />

              <label className="forminput" htmlFor="password">
                Password:
              </label>

              <div>
                <input
                  className="register-input"
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
                {/* {error && <p className="log-in-error">{error}</p>} */}
              </div>
              {error && <p className="log-in-error">{error}</p>}
              {/* <span>Remember Me</span> */}
              <div className="register-btn-container">
                {loading ? (
                  <Spinner />
                ) : (
                  <button className="login-button" type="submit">
                    Login
                  </button>
                )}
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
