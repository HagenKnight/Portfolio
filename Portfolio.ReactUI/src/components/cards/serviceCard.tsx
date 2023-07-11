import { Service } from "../../types/service";

export const ServiceCard = ({ name, description} : Service) => {

    return (
        <>
            <div className="info-block-w-icon">
                <div className="ci-icon">
                    <i className="lnr lnr-store"></i>
                </div>
                <div className="ci-text">
                    <h4>{name}</h4>
                    <p>{description}</p>
                </div>
            </div>
        </>
    );
};