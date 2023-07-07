import photo from '../../assets/img/main_photo.jpg';
import { DownloadButton } from '../common/downloadButton';
import { SocialNetworkLink } from '../common/socialNetworkLink';
import { Menu } from '../menu/menu';

export const HeaderCard = () => {

    const hyperlink: { url: string; icon: string; }[] = [
        { url: 'https://www.linkedin.com/in/giovannigarcia/', icon: 'fab fa-linkedin-in' },
        { url: 'https://www.instagram.com/hagenknight/', icon: 'fab fa-instagram' },
        { url: 'https://twitter.com/Kaseitech', icon: 'fab fa-twitter' },
    ];
    const fullName = "Giovanni García";
    const position = "Software Developer";
    
    return (
        <>
            <header id="site_header" className="header mobile-menu-hide">
                <Menu ></Menu>

                <div className="header-content">
                    <div className="header-photo">
                        <img src={photo} alt="Giovanni García" />
                    </div>
                    <div className="header-titles">
                        <h2>{fullName}</h2>
                        <h4>{position}</h4>
                    </div>
                </div>

                <div className="social-links">
                    <ul>
                        {
                            hyperlink.map((item, index) => { 
                                return <SocialNetworkLink key={index} url={item.url} icon={item.icon} /> 
                            })
                        }
                    </ul>
                </div>
                <DownloadButton></DownloadButton>
                <div className="copyrights">© 2023 All rights reserved.</div>
            </header>
        </>
    );
};