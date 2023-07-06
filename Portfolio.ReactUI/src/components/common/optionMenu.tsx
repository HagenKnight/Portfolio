interface option {
    hyperlink: string;
    icon: string;
    label: string;
    isSelected: boolean;
}

export const OptionMenu = ({ hyperlink, icon, label, isSelected }: option) => {
    const hyperlinkProperty = `#${hyperlink}`;
    const iconProperty = `menu-icon lnr ${icon}`;
    const labelProperty = label;
    const classNameProperty = isSelected ? "active" : "";

    return (
        <>
            <li className={classNameProperty}>
                <a href={hyperlinkProperty} className="nav-anim">
                    <span className={iconProperty}></span>
                    <span className="link-text">{labelProperty}</span>
                </a>
            </li>
        </>
    );
};