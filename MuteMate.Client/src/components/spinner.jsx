import React from "react";
import "../Styles/spinner.css";
import disappointedMonkey from "../images/disappointedMonkey.png";
import banana from "../images/banana.png";


function Spinner() {
  return (
    <>
    
        <div className="spinner-wrapper">
          <div className="small-spinner-container">
            <div className="spinner"></div>
            <img
              src={disappointedMonkey}
              alt="Monkey"
              className="small-spinner-monkey-img"
            />
            <img
              className="small-spinner-banana-img banana-1"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-2"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-3"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-4"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-5"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-6"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-7"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-8"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-9"
              src={banana}
              alt="Banana"
            />
            <img
              className="small-spinner-banana-img banana-10"
              src={banana}
              alt="Banana"
            />
          </div>
        </div>
      
    </>
  );
}

export default Spinner;
