import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import { NavLink } from "react-router-dom";
import Spinner from "../components/spinner";
import "../Styles/register.css";
import { Spin } from "hamburger-react";

function Register() {
  // state variables for email and passwords
  const [email, setEmail] = useState("");
  const [userName, setUserName] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [isLoading, setIsLoading] = useState(false); // Börjar med isLoading = false
  const navigate = useNavigate();

  // state variable for error messages
  const [error, setError] = useState("");

  const handleLoginClick = () => {
    navigate("/login");
  };

  // handle change events for input fields
  const handleChange = (e) => {
    const { name, value } = e.target;
    if (name === "email") setEmail(value);
    if (name === "userName") setUserName(value);
    if (name === "password") setPassword(value);
    if (name === "confirmPassword") setConfirmPassword(value);
  };

  // handle submit event for the form
  const handleSubmit = (e) => {
    e.preventDefault();
    // validate email and passwords
    if (!email || !userName || !password || !confirmPassword) {
      setError("Please fill in all fields.");
    } else if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
      setError("Please enter a valid email address.");
    } else if (password !== confirmPassword) {
      setError("Passwords do not match.");
    } else {
      // clear error message
      setError("");
      setIsLoading(true); // Startar spinner när vi skickar begäran
      // post data to the /register api
      fetch(ENDPOINTS.REGISTER, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          email: email,
          userName: userName,
          password: password,
        }),
      })
        //.then((response) => response.json())
        .then((data) => {
          // handle success or error from the server
          console.log(data);
          if (data.ok) {
            setError("Successful register.");
            // setTimeout(() => {
            navigate("/login");
            // }, 1500); // 1 sekund fördröjning så man hinner se meddelandet
            setIsLoading(false);
          } else {
            setError("Error registering.");
            setIsLoading(false); // Stoppa spinnern vid fel
          }
        })
        .catch((error) => {
          // handle network error
          console.error(error);
          setError("Error registering.");
          setIsLoading(false); // Stoppa spinnern vid fel
        });
    }
  };

  return (
    <div className="register-container">
      <div className="containerbox">
        <div>
          <div className="image-container"></div>

          <h3 className="register-text">Register</h3>
          <div className="form-container register-form-left">
            <form onSubmit={handleSubmit}>
              <label className="register-label-text" htmlFor="email">
                Email:
              </label>

              <input
                className="register-input"
                type="email"
                id="email"
                name="email"
                value={email}
                onChange={handleChange}
              />

              <label className="register-label-text" htmlFor="username">
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

              <label className="register-label-text" htmlFor="password">
                Password:
              </label>

              <input
                className="register-input"
                type="password"
                id="password"
                name="password"
                value={password}
                onChange={handleChange}
              />

              <label className="register-label-text" htmlFor="confirmPassword">
                Confirm Password:
              </label>
              <input
                className="register-input"
                type="password"
                id="confirmPassword"
                name="confirmPassword"
                value={confirmPassword}
                onChange={handleChange}
              />
              {error && <p className="register-error">{error}</p>}

              <div className="register-btn-container">
                {isLoading ? (
                  <Spinner />
                ) : (
                  <button className="register-button" type="submit">
                    Register
                  </button>
                )}
                <NavLink to="/login" className="register-login">
                  Already have an account? Log in.
                </NavLink>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Register;
