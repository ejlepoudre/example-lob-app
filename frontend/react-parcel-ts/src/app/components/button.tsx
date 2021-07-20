import * as React from "react";

interface IProps {
  flavor?: "primary" | "secondary"
  onClick: () => void;
  enable?: boolean;
}

export const Button: React.FunctionComponent<IProps> = (props) => {
  const className = `lob-button ${props.flavor == "secondary" ? "lob-bs-secondary" : "lob-bs-primary"}`;
  const disabled = props.enable === false;
  return (
    <button
      className={className}
      disabled={disabled}
      onClick={() => {
        if (!disabled) props.onClick();
      }}>
      {props.children}
    </button>
  );
};
