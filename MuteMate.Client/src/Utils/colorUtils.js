export const getColorClass = (answer) => {
  switch (answer.toLowerCase()) {
    case "orange":
      return "orange-text common-style";
    case "blue":
      return "blue-text common-style";
    case "red":
      return "red-text common-style";
    case "green":
      return "green-text common-style";
    case "yellow":
      return "yellow-text common-style";
    case "purple":
      return "purple-text common-style";
    case "black":
      return "black-text common-style";
    case "grey":
      return "grey-text common-style";
    case "pink":
      return "pink-text common-style";
    case "white":
      return "white-text common-style";
    case "brown":
      return "brown-text common-style";
    default:
      return "";
  }
};
