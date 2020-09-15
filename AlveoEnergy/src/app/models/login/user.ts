import { Guid } from '../../classes/guid';

export class User {
    id: Guid;
    username: string;
    password: string;
    firstName: string;
    lastName: string;
    authdata?: string;
}