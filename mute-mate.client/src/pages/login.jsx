import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import "../Styles/login.css";
import { NavLink } from "react-router-dom";
function Login() {
  // state variables for email and password
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [rememberme, setRememberme] = useState(false);
  // state variable for error messages
  const [error, setError] = useState("");
  const navigate = useNavigate();

  // handle change events for input fields
  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    if (name === "email") setEmail(value);
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
    if (!email || !password) {
      setError("Please fill in all fields.");
    } else {
      // clear error message
      setError("");
      // post data to the /login api
      const loginurl = rememberme
        ? `${ENDPOINTS.LOGIN}?useCookies=true`
        : `${ENDPOINTS.LOGIN}?useSessionCookies=true`;

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
          // handle success or error from the server
          if (response.ok) {
            setError("Successful Login.");
            window.location.href = "/";
          } else {
            setError("Error Logging In.");
          }
        })
        .catch((error) => {
          // handle network error
          console.error(error);
          setError("Error Logging in.");
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
                {/* {error && <p className="log-in-error">{error}</p>} */}
              </div>
              {error && <p className="log-in-error">{error}</p>}
              {/* <span>Remember Me</span> */}
              <div className="register-btn-container">
                <button className="login-button" type="submit">Login</button>

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
