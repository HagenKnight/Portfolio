interface hyperlink {
    url: string;
    icon: string;
  }

export const SocialNetworkLink = ({ url, icon}: hyperlink) => {

    return (
        <>
            <li><a href={url} target="_blank" rel="noreferrer"><i className={icon}></i></a></li>
        </>
    );

};