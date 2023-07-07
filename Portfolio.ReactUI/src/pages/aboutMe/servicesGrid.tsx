import { ServiceCard } from "../../components/cards/serviceCard";
import { Service } from "../../types/service";

export const ServicesGrid = (professionalServices: Service[]) => {

    return (
        <>
            <div className="row">
                <div className="col-xs-12 col-sm-12">
                    <div className="block-title">
                        <h3>What <span>I Do</span></h3>
                    </div>
                </div>
            </div>

            <div className="row">
                <div className="col-xs-12 col-sm-6">
                    <div className="col-inner">
                        {
                            // professionalServices.map(item => (
                            //     <ServiceCard key={item.name} {...item} />
                            // ))
                        }
                    </div>
                </div>
            </div>
        </>
    );
};