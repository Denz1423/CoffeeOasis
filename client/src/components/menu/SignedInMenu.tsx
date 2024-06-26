import React from "react";
import Button from "@mui/material/Button";
import Menu from "@mui/material/Menu";
import MenuItem from "@mui/material/MenuItem";
import { useAppDispatch, useAppSelector } from "../../store/configureStore";
import { Fade } from "@mui/material";
import { signOut } from "../account/accountSlice";
import { clearBasket } from "../basket/basketSlice";

export default function SignedInMenu() {
  const dispatch = useAppDispatch();
  const { user } = useAppSelector((state) => state.account);
  const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
  const open = Boolean(anchorEl);

  const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorEl(event.currentTarget);
  };

  const handleClose = () => {
    setAnchorEl(null);
  };

  return (
    <>
      <Button onClick={handleClick} color="inherit" sx={{ typography: "h6" }}>
        {user?.email}
      </Button>
      <Menu
        anchorEl={anchorEl}
        open={open}
        onClose={handleClose}
        TransitionComponent={Fade}
      >
        <MenuItem
          onClick={() => {
            dispatch(signOut()), dispatch(clearBasket());
          }}
        >
          Logout
        </MenuItem>
      </Menu>
    </>
  );
}
