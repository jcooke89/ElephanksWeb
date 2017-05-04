import { Http, Response } from '@angular/http';
import { Injectable } from "@angular/core";
import { Observable } from 'rxjs/Observable';
import { ITrunk } from './trunk';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';

@Injectable()
export class TrunkService {
    private _trunksUrl = '/api/trunks/trunks';

    constructor(private _http: Http) { }

    getTrunks(): Observable<ITrunk[]> {
        return this._http.get(this._trunksUrl)
            .map((response: Response) => <ITrunk[]>response.json())
            .do(data => console.log('All : ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.log(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}