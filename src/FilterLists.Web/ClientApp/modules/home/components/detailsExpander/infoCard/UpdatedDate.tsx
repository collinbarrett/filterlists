import * as React from "react";

interface IProps {
    updatedDate: string;
};

export const UpdatedDate = (props: IProps) =>
    props.updatedDate
    ? <li className="list-group-item">
          <p>Updated: (props.updatedDate).isValid()
                           ? (props.updatedDate).DateTimeFormat(["utc"]).format(date)
                           : "N/A"}</p>
      </li>
    : null;
