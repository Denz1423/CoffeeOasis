import { Checkbox, FormControlLabel } from "@mui/material";
import { UseControllerProps, useController } from "react-hook-form";

interface CheckboxProps extends UseControllerProps {
  label: string;
  disabled: boolean;
}

export default function AppCheckbox(props: CheckboxProps) {
  const { field } = useController({ ...props, defaultValue: false });
  return (
    <FormControlLabel
      control={
        <Checkbox
          {...field}
          checked={field.value}
          color="secondary"
          disabled={props.disabled}
        />
      }
      label={props.label}
    />
  );
}
