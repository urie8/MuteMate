import React from "react";
import happyMonkey from "../images/happyMonkey.png";
import sadMonkey from "../images/sadMonkey.png";
import disappointedMonkey from "../images/disappointedMonkey.png";
import contentMonkey from "../images/contentMonkey.png";
import angryMonkey from "../images/angryMonkey.png";

function MonkeyReaction({ isCorrect }) {
  console.log("Rendering MonkeyReaction with isCorrect:", isCorrect);

  if (isCorrect === null) {
    return null; // Om inget svar är valt så visas inget
  }

  const happyMonkeys = [happyMonkey, contentMonkey];

  const sadMonkeys = [sadMonkey, disappointedMonkey, angryMonkey];

  const monkeyImage = isCorrect
    ? happyMonkeys[Math.floor(Math.random() * happyMonkeys.length)]
    : sadMonkeys[Math.floor(Math.random() * sadMonkeys.length)];

  const message = isCorrect ? "Right!" : "Wrong!";
const messageClass = isCorrect ? "correct-text" : "incorrect-text"; 
  return (
    <div className="monkey-reaction-container">
      <h2 className={`monkey-answer-text ${messageClass}`}>{message}</h2>
      <img
        src={monkeyImage}
        alt={isCorrect ? "Happy Monkey" : "Sad Monkey"}
        className="monkey-reaction-image"
      />
    </div>
  );
}

export default MonkeyReaction;
