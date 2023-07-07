interface Size{
    size: number;
}

export const WhiteSpace = ({size} : Size) => { 
    const whiteSpaceClass = `white-space-${size}`;
    return (
        <>
            <div className={whiteSpaceClass}></div>
        </>
    );
};