import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { User } from '../models/login/user';
import { LoginRequest } from '../models/login/login-request';
import { Environment } from '../classes/environment';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private currentUserSubject: BehaviorSubject<User>;
    public currentUser: Observable<User>;

    constructor(private httpClient: HttpClient) {
        this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
        this.currentUser = this.currentUserSubject.asObservable();
    }

    public get controllerURL(): string {
        return `${Environment.apiUrl}/Login`;
      }

    public get currentUserValue(): User {
        return this.currentUserSubject.value;
    }

    login(loginRequest: LoginRequest) {
        return this.httpClient.post(`${this.controllerURL}/Login`, loginRequest)
            .pipe(
                map((user: User) => {
                    user.Authdata = window.btoa(user.UserName + ':' + user.Password);
                    localStorage.setItem('currentUser', JSON.stringify(user));
                    this.currentUserSubject.next(user);
                    return user;
                })
            );
    }

    logout() {
        localStorage.removeItem('currentUser');
        this.currentUserSubject.next(null);
    }
}