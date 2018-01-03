import { Component, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import { iSpendiCryService } from '../../../../Services/AccountService';

@Component({
    selector: 'accounts',
    templateUrl: './accounts.component.html',
    styleUrls: ['./accounts.component.css']
})
export class AccountsComponent {
    public AccountList = [];
    public constructor(private AccService: iSpendiCryService) {
        this.AccService.getAccounts()
            .subscribe(
            (data: Response) => (this.AccountList = data.json()));
    }
}