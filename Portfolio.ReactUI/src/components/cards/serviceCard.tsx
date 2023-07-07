import { Service } from "../../types/service";

export const ServiceCard = (services: Service) => {

    return (
        <>
            <div className="info-block-w-icon">
                <div className="ci-icon">
                    <i className="lnr lnr-store"></i>
                </div>
                <div className="ci-text">
                    <h4>{services.name}</h4>
                    <p>{services.description}</p>
                </div>
            </div>
        </>
    );
};