import { ServiceCard } from "../../components/cards/serviceCard";
import { Service } from "../../types/service";

interface Props {
    professionalServices: Service[];
}

export const ServicesGrid = ({ professionalServices }: Props) => {

    const columnA = professionalServices.filter((_, index) => index % 2 === 0);
    const columnB = professionalServices.filter((_, index) => index % 2 !== 0);;

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
                <div className="col-xs-12 col-md-6">
                    <div className="col-inner ">
                        {
                            columnA.map((service, index) => (
                                <ServiceCard key={index} {...service} />
                            ))
                        }
                    </div>
                </div>

                <div className="col-xs-12 col-md-6">
                    <div className="col-inner ">
                        {
                            columnB.map((service, index) => (
                                <ServiceCard key={index} {...service} />
                            ))
                        }
                    </div>
                </div>

            </div>
        </>
    );
};