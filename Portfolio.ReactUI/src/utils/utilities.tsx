export const age = (birthDate: string): number => {
    return Math.floor((new Date().getTime() - new Date(birthDate).getTime()) / 3.15576e+10);
}