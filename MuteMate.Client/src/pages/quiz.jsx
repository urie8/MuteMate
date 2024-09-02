import AuthorizeView from "../components/authorizeView";
import QuizComponent from "../components/quizComponent";
function Quiz() {
  return (
    <>
      <div className="quizPage-container">
        <AuthorizeView>
          <QuizComponent></QuizComponent>
        </AuthorizeView>
      </div>
    </>
  );
}

export default Quiz;
