import { Guid } from '../../classes/guid';

export class User {
    ID: Guid;
    Name: string;
    UserName: string;
    Password: string;    
    LastName: string;
    Authdata?: string;
    Email: string;
}