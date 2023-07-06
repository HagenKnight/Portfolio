import { OptionMenu } from "../common/optionMenu";

export const Menu = () => {
    return (
        <>
            <ul className="main-menu">
                <OptionMenu hyperlink={"home"} icon={"lnr-home"} label={"Home"} isSelected={true}></OptionMenu>
                <OptionMenu hyperlink={"about-me"} icon={"lnr-user"} label={"About Me"} isSelected={false}></OptionMenu>
                <OptionMenu hyperlink={"resume"} icon={"lnr-graduation-hat"} label={"Resume"} isSelected={false}></OptionMenu>
                <OptionMenu hyperlink={"portfolio"} icon={"lnr-briefcase"} label={"Portfolio"} isSelected={false}></OptionMenu>
                <OptionMenu hyperlink={"contact"} icon={"lnr-envelope"} label={"Contact me!"} isSelected={false}></OptionMenu>
            </ul>
        </>
    );
};