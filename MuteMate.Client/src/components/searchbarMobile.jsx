import React from "react";
import "../Styles/practiceAnimalsComponent.css"; 

function SearchBarMobile({ searchQuery, setSearchQuery }) {
  return (
    <div className="search-container-mobile">
      <div className="search-bar-container-mobile">
        <input
          type="text"
          placeholder="Search ..."
          value={searchQuery}
          onChange={(e) => setSearchQuery(e.target.value)}
          className="search-input-mobile"
        />
      </div>
    </div>
  );
}

export default SearchBarMobile;
