import { Service } from "../../types/service";
import { WorkerProfile } from '../../types/workerProfile';

import { ProfileCard } from "../../components/cards/profileCard";
import { WhiteSpace } from "../../components/common/whiteSpace";
import { ServicesGrid } from "./servicesGrid";

export const AboutMePage = () => {

    const workerProfileData: WorkerProfile = {
        firstName: "Miguel",
        lastname: "Gonzalez",
        email: "any@example.com",
        aboutMe: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur leo est, feugiat nec elementum id, suscipit id nulla..",
        birthDate: "1982-05-21",
        phone: "123456789",
        address: "Calle 123",
        city: "Bogota",
        country: { nameEn: "Colombia", nameEs: "Colombia", iSO2: "CO", iSO3: "COL" },
    }

    const professionalServices: Service[] = [
        { name: "Ecommerce", description: "Pellentesque pellentesque, ipsum sit amet auctor accumsan, odio tortor bibendum massa, sit amet ultricies ex lectus scelerisque nibh. Ut non sodales." },
        { name: "Web Design", description: "Pellentesque pellentesque, ipsum sit amet auctor accumsan, odio tortor bibendum massa, sit amet ultricies ex lectus scelerisque nibh. Ut non sodales." },
        { name: "Copywriting", description: "Pellentesque pellentesque, ipsum sit amet auctor accumsan, odio tortor bibendum massa, sit amet ultricies ex lectus scelerisque nibh. Ut non sodales." },
    ];

    return (
        <>
            <section data-id="about-me" className="animated-section">
                <div className="page-title">
                    <h2>About <span>Me</span></h2>
                </div>

                <div className="section-content">

                    <ProfileCard {...workerProfileData}></ProfileCard>

                    <WhiteSpace size={50}></WhiteSpace>

                    <ServicesGrid {...professionalServices}></ServicesGrid>
                </div>
            </section>
        </>
    );
};