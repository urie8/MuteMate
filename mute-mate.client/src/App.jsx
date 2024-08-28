import {
  Route,
  createBrowserRouter,
  createRoutesFromElements,
  RouterProvider,
} from "react-router-dom";
import "./App.css";
import MainLayout from "./layouts/MainLayout";
import Home from "./pages/home";
import CategoryPractise from "./pages/CategoryPractise";
import CategoryQuiz from "./pages/CategoryQuiz";
import LogIn from "./pages/login";
import MyPage from "./pages/myPage";
import Practise from "./pages/Practise";
import Register from "./pages/register";
import Quiz from "./pages/quiz";
import NotFound from "./pages/NotFound";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<MainLayout />}>
      <Route index element={<Home />} />
      <Route path="/register" element={<Register />} />
      <Route path="/login" element={<LogIn />} />
      <Route path="/myPage" element={<MyPage />} />
      <Route path="/categoryPractise" element={<CategoryPractise />} />
      <Route path="/categoryQuiz" element={<CategoryQuiz />} />
      <Route path="/practise" element={<Practise />} />
      <Route path="/quiz/:category" element={<Quiz />} />

      <Route path="*" element={<NotFound />} />
    </Route>
  )
);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
