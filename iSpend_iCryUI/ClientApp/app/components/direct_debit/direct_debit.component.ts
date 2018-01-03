import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Http, Response } from '@angular/http';
import { iSpendiCryService } from '../../../../Services/AccountService';

@Component({
    selector: 'app-direct_debit',
    templateUrl: './direct_debit.component.html',
    styleUrls: ['./direct_debit.component.css']
})
/** Direct Debit component*/
export class DirectDebitComponent {
    /** Direct Debit ctor */

    id: string;
    public direct_debits = [];
    constructor(private route: ActivatedRoute, private _service: iSpendiCryService) {
        this.route.params.subscribe(params => {
            this.id = params['id'];
        });

        this._service.getDirectDebits(this.id)
            .subscribe(
            (data: Response) => (this.direct_debits = data.json()));
    }
}