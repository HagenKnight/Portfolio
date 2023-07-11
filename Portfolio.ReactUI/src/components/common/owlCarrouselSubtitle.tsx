import OwlCarousel from 'react-owl-carousel';

interface Subtitle {
    jobPosition: string[];
}

export const OwlCarrouselSubtitle = ({ jobPosition }: Subtitle) => {

    return (
        <>
            <div className="text-rotation">
                <OwlCarousel items={1} loop={true} dots={false} autoplay={true} autoplayTimeout={4000} margin={jobPosition.length}>
                    {
                        jobPosition.map((item, key) => (<div className="sp-subtitile" key={key} >{item}</div>))
                    }
                </OwlCarousel>
            </div>
        </>
    );
};