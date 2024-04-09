import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
  const settings = {
    dots: true,
    infinite: true,
    autoplay: true,
    slidesToShow: 1,
    slidesToScroll: 1,
    speed: 3000,
    autoplaySpeed: 2000,
    cssEase: "linear",
    pauseOnHover: true,
  };

  return (
    <>
      <Slider {...settings} arrows={false}>
        <div>
          <img
            src="/images/banner/banner1.jpg"
            alt="banner1"
            style={{ display: "block", width: "100%", maxHeight: "650px" }}
          />
        </div>
        <div>
          <img
            src="/images/banner/banner2.jpg"
            alt="banner2"
            style={{ display: "block", width: "100%", maxHeight: "650px" }}
          />
        </div>
        <div>
          <img
            src="/images/banner/banner3.jpg"
            alt="banner3"
            style={{ display: "block", width: "100%", maxHeight: "650px" }}
          />
        </div>
      </Slider>
      <Box display="flex" justifyContent="center" sx={{ p: 4 }}>
        <Typography variant="h1">Welcome to Coffee Oasis!</Typography>
      </Box>
    </>
  );
}
