export const HomePage = () => {

    const fullName = "Giovanni García";
    const position: string[] = ["Software Developer", "Hardware Developer", ".Net Developer", "React Developper"];

    return (
        <>
            <section data-id="home" className="animated-section start-page">
                <div className="section-content vcentered">
                    <div className="row">
                        <div className="col-sm-12 col-md-12 col-lg-12">
                            <div className="title-block">
                                <h2>{fullName}</h2>
                                <div className="owl-carousel text-rotation">
                                    <div className="item">
                                        <div className="sp-subtitle">{position[0]}</div>
                                    </div>

                                    <div className="item">
                                        <div className="sp-subtitle">{position[1]}</div>
                                    </div>

                                    <div className="item">
                                        <div className="sp-subtitle">{position[2]}</div>
                                    </div>

                                    <div className="item">
                                        <div className="sp-subtitle">{position[3]}</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    );
};