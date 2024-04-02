import { Elements } from "@stripe/react-stripe-js";
import CheckoutPage from "./CheckoutPage";
import { loadStripe } from "@stripe/stripe-js";
import { useAppDispatch } from "../../store/configureStore";
import { useEffect, useState } from "react";
import agent from "../../api/agent";
import { setBasket } from "../basket/basketSlice";
import Loading from "../Loading";

const stripePromise = loadStripe(
  "pk_test_51P1Eh4IXRCDGjHPljS6Cv0hGj8Zqh8fleZfMJFEde3wtcbvtfQiRKZvuBL4HvBR4pLv4e2ka9ErVoKiPQYnnM0zM00ia5bQuAF"
);

export default function CheckoutWrapper() {
  const dispatch = useAppDispatch();
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    agent.Payments.createPaymentIntent()
      .then((response: any) => dispatch(setBasket(response)))
      .catch((error: any) => console.log(error))
      .finally(() => setLoading(false));
  }, [dispatch]);

  if (loading) return <Loading message="Loading Checkout..." />;

  return (
    <Elements stripe={stripePromise}>
      <CheckoutPage />
    </Elements>
  );
}
