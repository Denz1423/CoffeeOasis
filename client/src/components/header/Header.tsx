import { AppBar, Switch, Toolbar, Typography, styled } from "@mui/material";

interface Props{
    darkMode: boolean;
    handleThemeChange: () => void;
}

export default function Header({darkMode, handleThemeChange,} : Props) {
  return (
    <AppBar position="static" sx={{ mb: 4 }}>
      <Toolbar>
        <Typography variant="h6">Coffee Oasis</Typography>
        <Switch onChange={handleThemeChange} checked={darkMode}></Switch>
      </Toolbar>
    </AppBar>
  );
}
