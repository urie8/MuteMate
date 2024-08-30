import "../Styles/notFound.css";
import { useNavigate } from "react-router-dom";


function notFound() {
  const navigate = useNavigate();
  const handleGoBackClick = () => {
    navigate("/");};

  return (
    <>
    <div className="notfound-container">
      <div className="notfound-text">
        <div className="numbers-notfound"> 404</div>
        <div className="text-notfound">Page Not Found</div>
        <div className="go-back-btn" onClick={handleGoBackClick}>Go back</div>
      </div>
    </div>
    </>
  );
}

export default notFound;
