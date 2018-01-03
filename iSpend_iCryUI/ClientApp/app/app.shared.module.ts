import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule, JsonpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { AccountsComponent } from './components/accounts/accounts.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { BrowserModule } from '@angular/platform-browser';
import { HomeComponent } from './components/home/home.component';
import { iSpendiCryService } from '../../Services/AccountService';
import { TransactionComponent } from './components/transaction/transaction.component';
import { DirectDebitComponent } from './components/direct_debit/direct_debit.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        AccountsComponent,
        HomeComponent,
        TransactionComponent,
        DirectDebitComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'accounts', component: AccountsComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'transactions/:id', component: TransactionComponent },
            { path: 'direct_debits/:id', component: DirectDebitComponent },

            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [iSpendiCryService
    ]
})
export class AppModuleShared {
}