import { useState, CSSProperties } from "react";
import { ScaleLoader } from "react-spinners";

function Spinner() {
  const [loading, setLoading] = useState(true);

  return (
    <div className="loader">
      <ScaleLoader
        loading={loading}
        size={150}
        aria-label="Loading Spinner"
        data-testid="loader"
      />
    </div>
  );
}

export default Spinner;
