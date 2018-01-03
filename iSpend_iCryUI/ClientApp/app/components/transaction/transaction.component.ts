import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Http, Response } from '@angular/http';
import { iSpendiCryService } from '../../../../Services/AccountService';

@Component({
    selector: 'app-transaction',
    templateUrl: './transaction.component.html',
    styleUrls: ['./transaction.component.css']
})
/** transaction component*/
export class TransactionComponent {
    /** transaction ctor */

    id: string;
    public transactions = [];
    constructor(private route: ActivatedRoute, private _service: iSpendiCryService) {
        this.route.params.subscribe(params => {
            this.id = params['id'];
        });

        this._service.getTransactions(this.id)
            .subscribe(
            (data: Response) => (this.transactions = data.json()));
    }
}