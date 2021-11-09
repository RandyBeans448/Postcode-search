import "./App.css";
import React, { useState } from "react";
import axios from "axios";

function App() {
  const [postcode, setPostcode] = useState("");
  const [results, setResults] = useState([]);
  const [error, setError] = useState("");

  const api = `http://localhost:5000/postcode?postcode=${postcode}`;

  const submit = async (event) => {
    setResults("");
    event.preventDefault();
    if (!postcode) {
      setError("Please enter a postcode");
    } else {
      setError("");
      axios
        .get(api)
        .then((res) => {
          setResults(res.data);
        })
        .catch((error) => {
          console.log(error, "errors");
        });
    }
  };

  return (
    <div className="App">
      <div className="container">
        <h1 className="title">Postcode Search</h1>
        <p className="error">{error}</p>
        <form onSubmit={submit}>
        <div className="input-box">
          <input
            placeholder="Enter postcode...."
            className="input"
            onChange={(e) => setPostcode(e.target.value)}
          ></input>
          <button className="button" onClick={submit}>
            submit
          </button>
        </div>
        </form>
        <div className="results-box">
          <div>
            {!results
              ? null
              : results.map((result) => {
                  return <p className="results-text">{result}</p>;
                })}
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
