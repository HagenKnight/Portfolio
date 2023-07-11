import { OwlCarrouselSubtitle } from "../../components/common/owlCarrouselSubtitle";

export const HomePage = () => {

    const fullName = "Giovanni García";
    const jobPositions: string[] = ["Software Developer", "Hardware Developer", ".Net Developer", "React Developper"];

    return (
        <>
            <section data-id="home" className=" 
            start-page"
            // animated-section               
            >
                <div className="section-content vcentered">
                    <div className="row">
                        <div className="col-sm-12 col-md-12 col-lg-12">
                            <div className="title-block">
                                <h2>{fullName}</h2>
                                <OwlCarrouselSubtitle jobPosition={jobPositions} />
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    );
};