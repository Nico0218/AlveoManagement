import { environment } from '../../environments/environment';

export class Environment {
    public static get production(): boolean {
        return environment.production;
    }

    public static set production(isProduction: boolean) {
        environment.production = isProduction;
    }

    public static get apiUrl(): string {
        return environment.apiUrl;
    }

    public static set apiUrl(apiURL: string) {
        environment.apiUrl = apiURL;
    }
}