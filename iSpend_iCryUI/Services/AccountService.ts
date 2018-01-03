import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class iSpendiCryService {
    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
    }

    getAccounts() {
        return this.http.get(this.baseUrl + 'api/accounts');
    }

    getTransactions(id: string) {
        return this.http.get(this.baseUrl + 'api/transactions/' + id);
    }

    getDirectDebits(id: string) {
        return this.http.get(this.baseUrl + 'api/direct_debits/' + id);
    }
}