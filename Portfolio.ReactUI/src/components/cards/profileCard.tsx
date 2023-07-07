import { WorkerProfile } from "../../types/workerProfile";

export const ProfileCard = (workerProfile: WorkerProfile) => {

    const age = (birthDate: string): number => {
        return Math.floor((new Date().getTime() - new Date(birthDate).getTime()) / 3.15576e+10);
    }

    return (
        <>
            <div className="row">
                <div className="col-xs-12 col-sm-7">
                    <p>{workerProfile.aboutMe}</p>
                </div>

                <div className="col-xs-12 col-sm-5">
                    <div className="info-list">
                        <ul>
                            <li>
                                <span className="title">Age</span>
                                <span className="value">{age(workerProfile.birthDate)}</span>
                            </li>

                            <li>
                                <span className="title">Residence</span>
                                <span className="value">{workerProfile.country?.nameEn}</span>
                            </li>

                            <li>
                                <span className="title">Address</span>
                                <span className="value">{workerProfile.address}</span>
                            </li>

                            <li>
                                <span className="title">e-mail</span>
                                <span className="value">{workerProfile.email}</span>
                            </li>

                            <li>
                                <span className="title">Phone</span>
                                <span className="value">{workerProfile.phone}</span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </>
    );
};