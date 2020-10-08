import { Injectable } from '@angular/core';
import { HttpRequest, HttpResponse, HttpHandler, HttpEvent, HttpInterceptor, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { delay, mergeMap, materialize, dematerialize } from 'rxjs/operators';

import { User } from '../models/login/user';

const users: User[] = [
    { id: 1, username: 'admin', password: 'ThisAdminPass', firstName: 'Tinus', lastName: 'Spangenberg' , email: "tinus@alveowater.co.za"},
    { id: 2, username: 'Morne', password: 'MV@Manage258', firstName: 'Morne', lastName: 'Viljoen', email: 'Morne.viljoen@alveoenergy.co.za'},
    { id: 3, username: 'Kobus', password: 'KB@Manage456', firstName: 'Kobus', lastName: 'Burger', email: 'kobus.burger@alveoenergy.co.za'},
    { id: 4, username: "D'andre", password: 'DV@Manage159', firstName: "D'andre", lastName: 'vosloo', email: 'dandre.vosloo@alveoenergy.co.za'},
    { id: 5, username: 'Gerhard', password: 'GK@Manage357', firstName: 'Gerhard', lastName: 'Kieser', email: 'gerhard.kieser@alveoenergy.co.za'}
];

@Injectable()
export class FakeBackendInterceptor implements HttpInterceptor {
    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const { url, method, headers, body } = request;


        return of(null)
            .pipe(mergeMap(handleRoute))
            .pipe(materialize())
            .pipe(delay(500))
            .pipe(dematerialize());

        function handleRoute() {
            switch (true) {
                case url.endsWith('/users/authenticate') && method === 'POST':
                    return authenticate();
                case url.endsWith('/users') && method === 'GET':
                    return getUsers();
                default:

                    return next.handle(request);
            }    
        }


        //Checks if user details are stored
        function authenticate() {
            debugger;
            const { username, password } = body;
            const user = users.find(x => x.username === username && x.password === password);
            if (!user) return error('Username or password is incorrect');
            return ok({
                id: user.id,
                username: user.username,
                firstName: user.firstName,
                lastName: user.lastName
            })
        }

        //Checks if user is logged in -- if not user cannot access route/control
        function getUsers() {
            if (!isLoggedIn()) return unauthorized();
            return ok(users);
        }


        //Return successfull Login
        function ok(body?) {
            return of(new HttpResponse({ status: 200, body }))
        }

        //Return Error if login un successfull
        function error(message) {
            return throwError({ error: { message } });
        }

        //returns unauthorized if user is not authorised for specific route/control
        function unauthorized() {
            return throwError({ status: 401, error: { message: 'Unauthorised' } });
        }

        //test user
        function isLoggedIn() {
            return headers.get('Authorization') === `Basic ${window.btoa('test:test')}`;
        }
    }
}

export let fakeBackendProvider = {
    provide: HTTP_INTERCEPTORS,
    useClass: FakeBackendInterceptor,
    multi: true
};