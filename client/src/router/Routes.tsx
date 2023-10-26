import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import HomePage from "../components/home/HomePage";
import Catalog from "../components/catalog/Catalog";
import ProductDetails from "../components/catalog/ProductDetails";
import AboutPage from "../components/about/AboutPage";
import ContactPage from "../components/contact/ContactPage";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      { path: "", element: <HomePage /> },
      { path: "catalog", element: <Catalog /> },
      { path: "catalog/:id", element: <ProductDetails /> },
      { path: "about", element: <AboutPage /> },
      { path: "contact", element: <ContactPage /> },
    ],
  },
]);
