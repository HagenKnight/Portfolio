import { Country } from "./country";

export interface WorkerProfile {
    firstName: string;
    lastname: string;
    aboutMe: string;
    birthDate: string;
    email: string;
    phone: string;
    address: string;
    city: string;
    country: Country | null;
}