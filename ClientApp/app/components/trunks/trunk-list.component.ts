import { Component, OnInit } from '@angular/core';
import { TrunkService } from './trunk.service';
import { ITrunk } from "./trunk";

@Component({
    selector: 'ng-trunk',
    templateUrl: './trunk-list.component.html',
    styleUrls: ['./trunk-list.component.css']
})
export class TrunksComponent implements OnInit {

    constructor(private _trunkService: TrunkService) { }
    ngOnInit(): void {
        this._trunkService.getTrunks()
            .subscribe(trunks => this.trunks = trunks,
            error => this.errorMessage = <any>error);
    }

    trunks: ITrunk[];
    errorMessage: string;
}
